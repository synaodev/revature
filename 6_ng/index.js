const express = require('express');
const path = require('path');

const server = express();

server.use(express.urlencoded({ extended: true }));
server.use(express.json());
server.use(express.static(path.join(__dirname, '/angular/dist/angular')));

server.get('*', (req, res) => {
	res.sendFile(path.resolve('./public/dist/public/index.html'));
});

server.listen(8000, console.log('Listening at port 8000!'));
