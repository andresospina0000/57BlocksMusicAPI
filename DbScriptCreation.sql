CREATE TABLE users (
    userId   INTEGER PRIMARY KEY AUTOINCREMENT,
    name     VARCHAR    NOT NULL,
    email    VARCHAR    NOT NULL,
    password VARCHAR    NOT NULL
);

CREATE TABLE artists (
    Id       INTEGER PRIMARY KEY AUTOINCREMENT,
    name     VARCHAR NOT NULL,
    abstract VARCHAR NOT NULL,
    userId   INTEGER NOT NULL,
    visible  BOOLEAN NOT NULL
);

CREATE TABLE Albums (
    Id      INTEGER PRIMARY KEY AUTOINCREMENT,
    name    VARCHAR NOT NULL,
    userId  INTEGER NOT NULL,
    visible BOOLEAN NOT NULL
);

CREATE TABLE songs (
    Id            INTEGER PRIMARY KEY AUTOINCREMENT,
    ArtistId      INTEGER NOT NULL,
    AlbumId       INTEGER NOT NULL,
    UserId        INTEGER NOT NULL,
    TrackDuration TEXT    NOT NULL,
    name          VARCHAR NOT NULL,
    visible       BOOLEAN NOT NULL
);

