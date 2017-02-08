"use strict"; 

console.log("lesson 1");

let dog = {
	sound: 'woof',
	talk: function() {
		console.log(this.sound);
	}
}

dog.talk();		//	"woof"


// let talkFunction = dog.talk;	//	js can assign a function to a variable (js is a functional programming language) 
// talkFunction();	//	undefined	Cannot read property 'sound' of undefined


let talkFunction = dog.talk;
let boundFunction = talkFunction.bind(dog);		//	force this bind with dog
boundFunction();	//	"woof"



// let button = document.getElemntById('myNiceButton');
// button.addEventListener(
// 	'click',
// 	dog.talk.bind(dog)    // if dog.talk, this refers to the window object where listener intriged
// )



console.log("lesson 2");

function talk() {
	console.log(this.sound);
}
let boromir = {
	speak: talk,
	sound: 'One does not simply walk into mordor'
}
let talkBoundToBoromir = talk.bind(boromir);
talkBoundToBoromir();

boromir.speak();



let boromir2 = {
	sound: 'One does not simply walk into mordor'
}
boromir2.speak = talk.bind(boromir2);
let blabber = boromir2.speak;
blabber();



console.log("boromir3:");
let boromir3 = {
	blabber: talk,
	sound: 'One does not simply walk into mordor'
}
let gollum = {
	jabber: boromir3.blabber,
	sound: 'My preciousssss...'
}
gollum.jabber();

//	functions are just values
//	'this' is context sensitive





