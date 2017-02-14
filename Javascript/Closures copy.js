//	https://www.youtube.com/watch?v=iZLP4qOwY8I&index=6&list=PL0zVEGEvSaeEd9hlmCXrk5yUyqUag-n84

//	Curry is when a function doesn't take all of its arguments up front
//	instead it wants you to give is the fist argument and the function returns another function
//	which you are supposed to call with the secondary which in turn will return a new function
//	which you are supposed to call with the third argument and so on untill all the arguments have been
//	provided and then the function at the end of chain will be the one that returns the value that you
//	actually wnat
import _ from 'lodash';

"use strict";


// let dragon = (name, size, element) =>
// 	name + ' is a ' +
// 	size + ' dragon that breathes ' + 
// 	element + '!'

// console.log(dragon('fluffykins', 'tiny', 'lightning'));



//	chain of functions

// let dragon = 
// 	name =>
// 		size =>
// 			element =>
// 				name + ' is a ' +
// 				size + ' dragon that breathes ' + 
// 				element + '!'

// let fluffykinsDragon = dragon('fluffykins');
// let tinyDragon = fluffykinsDragon('tiny');
// console.log(dragon('fluffykins')('tiny')('lightning'));
// console.log(tinyDragon('lightning'));



console.log('2nd half');
//	npm install lodash      -- in terminal

let dragon = (name, size, element) =>
	name + ' is a ' +
	size + ' dragon that breathes ' + 
	element + '!'

dragon = _.curry(dragon);

let fluffykinsDragon = dragon('fluffykins');
let tinyDragon = fluffykinsDragon('tiny');
console.log(tinyDragon('lightning'));


