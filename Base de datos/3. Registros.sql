--USUARIO
INSERT INTO dbo.Usuario
VALUES (1,1,'Juan','Medina','123456789','Av.ads','12345678','050201')
INSERT INTO dbo.Usuario
VALUES (2,2,'PEDRO','Merino','123456789','Av.das','12345678','010102')


--HOTEL
INSERT INTO dbo.Hotel
VALUES ('PARAISO3','BOLI','Tacna','Peru','2 Estrellas','8am','Nuevo2')
INSERT INTO dbo.Hotel
VALUES ('PARAISO4','AVER','Tacna','Peru','3 Estrellas','9am','Nuevo3')

--TIPO HABITACION
INSERT INTO dbo.Tipo_Hab
VALUES ('Matrimonial')

--TIPO USUARIO
INSERT INTO dbo.Tipo_Usuario
VALUES ('Cliente')
INSERT INTO dbo.Tipo_Usuario
VALUES ('Empresa')
INSERT INTO dbo.Tipo_Usuario
VALUES ('Administrador')

--DETALLE HOTEL
INSERT INTO dbo.Detalle_Hotel
VALUES (1,2)

--HABITACION
INSERT INTO dbo.Habitacion
VALUES (1,1,18,'Dis')

--TIPO DOCUMENTO
INSERT INTO dbo.Tipo_Documento
VALUES ('Dni')
INSERT INTO dbo.Tipo_Documento
VALUES ('CI')
INSERT INTO dbo.Tipo_Documento
VALUES ('Pasaporte')