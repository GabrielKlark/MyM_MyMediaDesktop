create database watching;

use watching;

create table tb_Media (
cod_M int not null primary key auto_increment
,title_M varchar(100)
,date_M varchar(10)
,season_M int(3)
,synopsis_M varchar(300)
);

alter table tb_Media
modify title_M varchar(100);

describe tb_Media;

select cod_M as 'Code', title_M as 'Title', date_M as 'Date', season_M as 'Num Seasons', synopsis_M as 'Synopsis' from tb_Media;

insert into tb_Media (title_M, date_M, season_M, synopsis_M)
values ("Fear Street Part One: 1994", "2021/07/07", null, "A circle of teenage friends accidentally encounter the ancient evil responsible for a series of brutal murders that have plagued their town for over 300 years. Welcome to Shadyside.")
,("Fear Street Part Two: 1978", "2021/07/09", null, "Shadyside, 1978. School's out for summer and the activities at Camp Nightwing are about to begin. But when another Shadysider is possessed with the urge to kill, the fun in the sun becomes a gruesome fight for survival.")
,("Fear Street Part Three: 1666", "2021/07/16", null, "The origins of Sarah Fier's curse are finally revealed as history comes full circle on a night that changes the lives of Shadysiders forever.")
,("Call Me By Your Name", null, null, "In 1980s Italy, romance blossoms between a seventeen-year-old student and the older man hired as his father's research assistant.")
,("How To Get Away With Muder", null, "6", "Brilliant criminal defense attorney and law professor Annalise Keating, plus five of her students, become involved in a twisted murder case."
);

select * from tb_Media;

#Procedures and Functions for Visual Studio
-- Insert
create procedure SP_InsertMedia(varTitle varchar(100), varDate char(10), varSeason int(3), varSynopsis varchar(300))
insert into tb_Media (title_M, date_M, season_M, synopsis_M)
values (varTitle, varDate, varSeason, varSynopsis);

call SP_InsertMedia('Happy Death Day',null,null, "College student Tree Gelbman mistreats people, but later that day, she is brutally murdered by a masked man. It turns out that she survives, or rather, wakes up on the same fateful day, in a sort of macabre loop that always ends with the girl's death.");

-- Delete
create procedure SP_DeleteMedia(varCod int)
delete from tb_Media where cod_M = varCod;

call SP_DeleteMedia(12);

update tb_Media
set season_M = null where cod_M = 0;

-- Update

update tb_Media
set title_M = "AAA", date_M = null, season_M = null, synopsis_M = null
where cod_M = 11;

select * from tb_Media;

create procedure SP_AlterMedia(varCod int, varTitle varchar(100), varDate char(10), varSeason int(3), varSynopsis varchar(300))
update tb_Media
set title_M = varTitle, date_M = varDate, season_M = varSeason, synopsis_M = varSynopsis
where cod_M = varCod;

call SP_AlterMedia(12, 'A', null, null, null);

#Triggers for Visual Studio

insert into tb_Media values
(
7, '47 Meters Down: Uncaged', '2021/09/25', 0, '...'
);

#Login
create table tbLogin (
	login varchar(30) not null primary key
    ,pass varchar(30) not null
    ,email varchar(50)
);

insert into tbLogin values('ds', '010101', 'gabrielklarketec@gmail.com');

select * from tbLogin;

select login from tbLogin where login like 'GabrielKlark';
