-- Ejercicio SQL
-- Antes de empezar con las consignas, crea las tablas e inserta los datos iniciales mediante correr los siguientes comandos CREATE e INSERT
-- Las 10 consignas están al final del archivo

-- artists (artistid,name)

create table artists
(
artistid bigint not null,
name character varying (100)
);

insert into artists(artistid, name)
values (1, 'Shakira'),
(2, 'Madonna'),
(3, 'Los Chalchaleros'),
(4, 'Gardel'),
(5, 'Los Tipitos'),
(6, 'U2'),
(7, 'Dos minutos'),
(8, 'ACDC'),
(9, 'The Beatles'),
(10, 'Rolling stones');

-- albums (albumid,name,year,artistid)

create table albums
(
albumid bigint not null,
name character varying (100),
year bigint,
artistid bigint
);

insert into albums (albumid,name,year,artistid)
values (1, 'Moscas en la casa', 1999, 1),
(2, 'Ciega, sorda, muda', 2001, 1),
(3, 'Shakira grandes éxitos', 2015, 1),
(4, 'Like a virgin', 1997, 2),
(5, 'Pop star', 1998, 2),
(6, 'Legend', 2009, 2),
(7, 'Se va la segunda', 1994, 3),
(8, 'Chalchaleros grandes éxitos', 2010, 3),
(9, 'La chalcha y los 20 chalchitos', 2005, 3),
(10, 'Tango 01', 1934, 4),
(11, 'El tango y la vida', 1935, 4),
(12, 'Yo argentino', 1933, 4),
(13, 'Tipazos', 2012, 5),
(14, 'Personas pequeñas', 2013, 5),
(15, 'Un poco loco', 2005, 5),
(16, 'The Joshua tree', 1998, 6),
(17, 'Vertigo', 2010, 6),
(18, 'Catorce', 2014, 6),
(19, 'Beautiful day', 2009, 6),
(20, 'Toto IV', 2003, 7),
(21, 'Animal', 2010, 7 ),
(22, 'Lalala', 1965, 9),
(23, 'Yeah yeah', 1968, 9),
(24, 'No reconocido', 2018, null);


-- 1) Listar todos los artistas.

-- 2) Listar los artistas cuyos nombres comienzan con 'L'.

-- 3) Listar los albums del artista 'Dos minutos'.

-- 4) Listar los artistas que sacaron un album en el 2010.

-- 5) Listar los artistas que tienen nombres que comienzan con 'G' o que sacaron un album en el 2005.

-- 6) Listar los albums que no tienen un artista asociado.

-- 7) Listar los albums de los artistas 'Shakira, Madonna, Los Chalchaleros y Gardel'. 

-- 8) Listar la cantidad de albums que tiene cada artista.

-- 9) Listar los artistas que no tienen albums.

-- 10) Listar los artistas que tienen más de 1 album. (Usar Group by y having).
