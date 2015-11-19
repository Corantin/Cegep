var http = require('http');

http.createServer(function name(req,res) {
	res.writeHead(200,{'Content-Type':'text/plain'});
	res.end('Bonjour de Node.js');
}).listen(1337,'127.0.0.1');
console.log("Le serveur est démarré : 127.0.0.1:1337");