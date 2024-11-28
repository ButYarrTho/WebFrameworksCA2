-- Create the database
CREATE DATABASE IF NOT EXISTS MediaLibrary;

-- Use the created database
USE MediaLibrary;

-- Create a table for artists
CREATE TABLE Artists (
                         ID INT AUTO_INCREMENT PRIMARY KEY,
                         Name VARCHAR(255) NOT NULL,
                         CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Create a table for movie titles
CREATE TABLE Movies (
                        ID INT AUTO_INCREMENT PRIMARY KEY,
                        Title VARCHAR(255) NOT NULL,
                        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Create a table for book titles
CREATE TABLE Books (
                       ID INT AUTO_INCREMENT PRIMARY KEY,
                       Title VARCHAR(255) NOT NULL,
                       CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Insert sample data into Artists
INSERT INTO Artists (Name)
VALUES
    ('Taylor Swift'),
    ('Ed Sheeran'),
    ('Billie Eilish');

-- Insert sample data into Movies
INSERT INTO Movies (Title)
VALUES
    ('Inception'),
    ('The Dark Knight'),
    ('Interstellar');

-- Insert sample data into Books
INSERT INTO Books (Title)
VALUES
    ('1984'),
    ('To Kill a Mockingbird'),
    ('The Great Gatsby');