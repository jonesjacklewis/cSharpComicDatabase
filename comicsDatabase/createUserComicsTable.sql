CREATE TABLE IF NOT EXISTS userComics (
	user_comic_id INTEGER PRIMARY KEY,
   	user_id INTEGER NOT NULL,
    comic_id INTEGER NOT NULL,
    FOREIGN KEY (user_id) REFERENCES users (user_id),
    FOREIGN KEY (comic_id) REFERENCES comics(comic_id)
);