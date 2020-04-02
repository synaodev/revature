export function success(res: Response) {
	let textarea: any = document.querySelector("#response");
	res.json().then(
		function(data) {
			let obj: any = {
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
			textarea.value = "ERROR";
		}
	)
}
export function failure(res: Response) {
	let textarea: any = document.querySelector("#response");
	textarea.value = "ERROR";
}