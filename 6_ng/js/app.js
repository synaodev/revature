import './event';

let header = document.querySelector('header');
let lis = document.querySelectorAll('nav li');

header.style.color = 'red';
lis.forEach(value => {
	value.style.backgroundColor = 'green';
});

function success(res) {
	let textarea = document.querySelector('#response');
	res.json().then(
		function(data) {
			let obj = {
				detail: null,
				name: null,
				mass: null
			};
			for (const key in obj) {
				obj[key] = data[key];
			}
			textarea.value = obj;
			console.log(obj);
		},
		function(error) {
			textarea.value = 'ERROR';
		}
	);
}

function failure(res) {
	let textarea = document.querySelector('#response');
	textarea.value = 'ERROR';
}

let main = document.querySelector('main');

main.addEventListener('click', clickEvent);


