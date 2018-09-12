INSERT INTO Roles VALUES ('Estudiante', 1)
INSERT INTO Roles VALUES ('Profesor', 1)

insert into State values('Mexico');
insert into State values('Puebla');
insert into State values('Jalisco');

insert into City values(1,'Nezahualcoyotl');
insert into City values(2,'Zaragoza');
insert into City values(3,'Guadalajara');

insert into ZipCode values(1,1,'Benito Juarez');
insert into ZipCode values(2,2,'Aurora');
insert into ZipCode values(3,3,'Malinche');

insert into Address values('Calle1',1,'11','A');
insert into Address values('Calle2',2,'22','B');
insert into Address values('Calle1',3,'33','C');

insert into Person values(20,1,'CURP1',2019273,'correo@dominio.com',1,'Sebas','Pioquinto');
insert into Person values(20,1,'CURP2',2019273,'otro@correo.com',1,'Jesus','Cruz');
insert into Person values(20,2,'CURP1',2019273,'YoSoy@TuPadre.com',1,'Luke','Skywalker');
insert into Person values(20,3,'CURP2',2019273,'tim@correo.com',1,'Tim','Burton');

insert into Student(PersonId,Account,IsActive) values(1,'218736217',1);
insert into Student(PersonId,Account,IsActive) values(3,'968721414',1);

insert into Teacher values(2,'RFC123',1);
insert into Teacher values(4,'RFC987',1);

insert into SchoolType values('Matutino');
insert into SchoolType values('Vespertino');
insert into SchoolType values('Mixto');

insert into School values('Escuela1',3,'Escuela1',1,6,1);
insert into School values('OtraEscuela',2,'OtraEscuela',3,7,1);

insert into Signatures values('Español',1);
insert into Signatures values('Matematicas',1);
insert into Signatures values('Ciencias Naturales',1);
insert into Signatures values('Geografia',1);

insert into WeekDay values('L,M,X,J,V');

insert into Inscription values(1,'Escuela1','20170911');

insert into Schedule values(1,'13:00','14:30');
insert into Schedule values(1,'10:00','11:30');
insert into Schedule values(1,'13:00','14:30');

insert into Course values('Esp1032',1,'Escuela1',1,6,5,560,'20170912','20180810',1,1);
insert into Course values('Mat546',2,'OtraEscuela',2,6,4,700,'20170912','20180810',1,2);

insert into Grade values('Esp1032',1,'1',1);
insert into Grade values('Mat546',2,'A',1);

insert into SchoolUser values(1,'Jose Jose','contraseña',1);
insert into SchoolUser values(2,'Juanga','reseña',1);

insert into work values('Escuela1',1);
