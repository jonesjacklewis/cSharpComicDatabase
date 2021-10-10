CREATE TABLE IF NOT EXISTS comics (
	comic_id INTEGER PRIMARY KEY,
   	title TEXT NOT NULL,
    isbn TEXT,
    mainCharacter TEXT NOT NULL,
    rating INTEGER NOT NULL,
    image blob NOT NULL,
    link text NOT NULL
);