-- Tables creation
create table ADMIN (
   ADMINID              int    identity(1,1) not null,
   USERID               int                  not null,
   NAME                 varchar(255)         not null,
   PHONENUMBER          int                  null,
   DEPARTMENT           varchar(255)         null,
   EMAIL                varchar(255)         not null,
   constraint PK_ADMIN primary key (ADMINID)
);
--insert into ADMIN(USERID, NAME, PHONENUMBER, DEPARTMENT, EMAIL) values(1, 'ahmed', '01002345676', 'IT', 'ahmed@gmail.com')
--insert into ADMIN(USERID, NAME, PHONENUMBER, DEPARTMENT, EMAIL) values(2, 'aya', '0108572576', 'IS', 'aya@gmail.com')
--select * from admin


create table AUTHOR (
   AUTHORID             int  identity (1,1)  not null,
   NAME                 varchar(255)         not null,
   EMAIL                varchar(255)         null,
   constraint PK_AUTHOR primary key (AUTHORID)
);

create table BOOK (
   ISBN                 varchar(20)          not null,
   ADMINID              int                  null,
   PUBLISHYEAR          int                  null,
   GENRE                varchar(255)         null,
   TITLE                varchar(255)         not null,
   PRICE                int                  not null,
   NUMCOPIES            int                  null,
   constraint PK_BOOK primary key (ISBN)
);


create table BOOKCOPY (
   ISBN                 varchar(20)          not null,
   COPYID               int     identity(1,1)      not null,
   STATUS               bit                  not null,
   constraint PK_BOOKCOPY primary key (ISBN, COPYID)
);

create table BORROW (
   STUDENTID            int                  not null,
   ISBN                 varchar(20)          not null,
   COPYID               int                  not null,
   BORROWDATE           datetime             null,
   EXPECTEDRETURN       datetime             null,
   ACTUALRETURN         datetime             null,
   constraint PK_BORROW primary key (ISBN, STUDENTID, COPYID)
);

create table LANGUAGE (
   LANGUAGE             varchar(255)  default('English')  not null,
   ISBN                 varchar(20)                       not null,
   constraint PK_LANGUAGE primary key (LANGUAGE, ISBN)
);

create table REGISTRATION (
   USERID               int  identity(1,1)   not null,
   PASSWORD             varchar(30)          not null,
   EMAIL                varchar(255)         not null,
   constraint PK_REGISTRATION primary key (USERID)
);

create table STUDENT (
   STUDENTID            int  identity(1, 1)  NOT NULL,
   USERID               int                  NOT NULL,
   NAME                 varchar(255)         NOT NULL,
   PHONENUMBER          varchar(255)                  NULL,
   EMAIL                varchar(255)         NOT NULL,
   COUNTRY              varchar(255)         NULL,
   CITY                 varchar(255)         NULL,
   STREET               varchar(255)         NULL,
   BIRTHDAY             int                  NULL,
   BIRTHMONTH           int                  NULL,
   BIRTHYEAR            int                  NULL,
   AGE                  int                  NULL,
   CONSTRAINT PK_STUDENT PRIMARY KEY (STUDENTID)
);

--insert into REGISTRATION values('123', 'aya');
--select * from REGISTRATION;

go
create table "UPDATE" (
   ADMINID              int                  not null,
   ISBN                 varchar(20)          not null,
   UPDATETYPE           varchar(20)  default('Changed Data')   null,
   constraint PK_UPDATE primary key (ADMINID, ISBN)
);

create table WRITE (
   ISBN                 varchar(20)          not null,
   AUTHORID             int                  not null,
   constraint PK_WRITE primary key (ISBN, AUTHORID)
);

-- Indexes creation
create nonclustered index SIGN_UP2_FK on ADMIN (USERID ASC);

create nonclustered index ADD_FK on BOOK (ADMINID ASC);

create nonclustered index HAS_FK on BOOKCOPY (ISBN ASC);

create nonclustered index BORROW_FK on BORROW (STUDENTID ASC);

create nonclustered index BORROW2_FK on BORROW (ISBN ASC, COPYID ASC);

create nonclustered index HAS_LANG_FK on LANGUAGE (ISBN ASC);

create nonclustered index SIGN_UP4_FK on STUDENT (USERID ASC);

create nonclustered index UPDATE_FK on "UPDATE" (ADMINID ASC);

create nonclustered index UPDATE2_FK on "UPDATE" (ISBN ASC);

create nonclustered index WRITE_FK on WRITE (ISBN ASC);

create nonclustered index WRITE2_FK on WRITE (AUTHORID ASC);

-- Foreign key constraints
alter table ADMIN
   add constraint FK_ADMIN_SIGN_UP2_REGISTRA foreign key (USERID)
      references REGISTRATION (USERID);

alter table BOOK
   add constraint FK_BOOK_ADD_ADMIN foreign key (ADMINID)
      references ADMIN (ADMINID);

alter table BOOKCOPY
   add constraint FK_BOOKCOPY_HAS_BOOK foreign key (ISBN)
      references BOOK (ISBN);

alter table BORROW
   add constraint FK_BORROW_BORROW_STUDENT foreign key (STUDENTID)
      references STUDENT (STUDENTID);

alter table BORROW
   add constraint FK_BORROW_BORROW2_BOOKCOPY foreign key (ISBN, COPYID)
      references BOOKCOPY (ISBN, COPYID);

alter table LANGUAGE
   add constraint FK_LANGUAGE_HAS_LANG_BOOK foreign key (ISBN)
      references BOOK (ISBN);

alter table STUDENT
   add constraint FK_STUDENT_SIGN_UP4_REGISTRA foreign key (USERID)
      references REGISTRATION (USERID);

alter table "UPDATE"
   add constraint FK_UPDATE_UPDATE_ADMIN foreign key (ADMINID)
      references ADMIN (ADMINID);

alter table "UPDATE"
   add constraint FK_UPDATE_UPDATE2_BOOK foreign key (ISBN)
      references BOOK (ISBN);

alter table WRITE
   add constraint FK_WRITE_WRITE_BOOK foreign key (ISBN)
      references BOOK (ISBN);

alter table WRITE
   add constraint FK_WRITE_WRITE2_AUTHOR foreign key (AUTHORID)
      references AUTHOR (AUTHORID);

go

-- Triggers creation
-- derived numcopies
CREATE TRIGGER UpdateNumCopies
ON BOOKCOPY
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE b
    SET b.NUMCOPIES = ISNULL((SELECT COUNT(bc.COPYID) FROM BOOKCOPY bc WHERE bc.ISBN = b.ISBN), 0)
    FROM BOOK b
    INNER JOIN inserted i ON b.ISBN = i.ISBN;
END;
go

-- derived return date
CREATE TRIGGER UpdateExpectedReturn
ON BORROW
AFTER UPDATE
AS
BEGIN
    IF UPDATE(ACTUALRETURN)
    BEGIN
        UPDATE b
        SET EXPECTEDRETURN = DATEADD(day, 7, i.ACTUALRETURN)
        FROM BORROW b
        INNER JOIN inserted i ON b.ISBN = i.ISBN AND b.STUDENTID = i.STUDENTID AND b.COPYID = i.COPYID;
    END;
END;
go

-- derived age
-- make age derived from birthdate
CREATE TRIGGER UpdateAge
ON STUDENT
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE s
    SET s.AGE = DATEDIFF(year, DATEFROMPARTS(s.BIRTHYEAR, s.BIRTHMONTH, s.BIRTHDAY), GETDATE())
    FROM STUDENT s
    INNER JOIN inserted i ON s.STUDENTID = i.STUDENTID;
END;
