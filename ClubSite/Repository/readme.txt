like this

create database club character set utf8mb4 collate utf8mb4_unicode_ci;

create table Asset (
	id int(11) not null auto_increment,
    createdDate datetime(3) not null,
    modifiedDate datetime(3) not null,
    deletedDate datetime(3) not null,
    deletedBy varchar(255) default null,
    guid varchar(255) default null,
    url varchar(255) default null,
    name varchar(255) default null,
    primary key (id),
    unique key UK_Asset_guid (guid)
);
