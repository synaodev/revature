
// class Movie {
// 	constructor(title) {
// 		this.title = title;
// 	}
// };

// let movie = new Movie('Fifth Element');
// let movie2 = new Movie('Fast and Furious');

// console.log(movie);
// console.log(movie2);

// function statement
// function add(a, b) {
// 	return a + b;
// }

// function add2(a, b) {
// 	if (typeof(a) == 'number' && typeof(b) == 'number') {
// 		return add(a, b);
// 	}
// 	return NaN;
// }

// let add3 = function(a, b) {
// 	return add2(a, b);
// }

// console.log(add3(1, 2));

// Iffy function
// (function add4(a, b) {
// 	return add3(a, b);
// })(1, 2);

// hoist

function outer(fn, arg) {
	function inner(arg) {
		console.log(arg);
	}
	console.log(fn);
	return inner;
}

// closure
function write() {
	let line = 1;
	return function print(msg) {
		console.log(line + ': ' + msg);
		line += 1;
	};
}
let write_line = write();
write_line('first');
write_line('second');
write_line('third');

function Human() {
	this.first_name = '';
	this.last_name = 'Frank';
	this.speak = (msg) => {
		let n = this.full_name();
		console.log(`${n} said ${msg}`);
	};
	this.set_name = (first, last) => {
		this.first_name = first;
		this.last_name = last;
	};
	this.full_name = () => {
		return `${first_name} ${last_name}`;
	};
}

let h = new Human();
