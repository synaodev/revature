import { success, failure } from './handler';

export default class EventHandler{
	apiNames: Array<string>;
	constructor() {
		this.apiNames = ['people', 'starships', 'planets'];
	}
	Click(event: any) {
		event.stopPropagation();
		console.log(event.target.id);
		let btn: string = event.target.id;
		switch (btn) {
			case 'btn-people':
				let text: any = document.querySelector('#people');
				fetch(`https://swapi.co/api/people/${text.value}`).then(
					success,
					failure
				);
				break;
			default:
				break;
		}
	}
}
