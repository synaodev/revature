import { success, failure } from "./handler";

export class EventHandler {
  Click(event: any) {
    event.stopPropagation();
    console.log(event.target.id);
    let btn = event.target.id;
    switch (btn) {
      case "btn-people":
        let text: any = document.querySelector("#people");
        fetch(`https://swapi.co/api/people/${text.value}`)
        .then(success, failure);
        break;
      default:
        break;
    }
  }
}