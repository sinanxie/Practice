//	https://www.youtube.com/watch?v=BMUiFMZr7vk&list=PL0zVEGEvSaeEd9hlmCXrk5yUyqUag-n84&index=1
//	functions are values
var triple = function (x) {
	return x * 3;
};

var waffle = triple;

waffle(30);

//	can put function into another function
//	Composition

var animals = [
	{ name: 'Fluffykins',	species:'rabbit' },
	{ name: 'Caro',			species:'dog' },
	{ name: 'Hamilton',		species:'dog' },
	{ name: 'Harold',		species:'fish' },
	{ name: 'Ursula',		species:'cat' },
	{ name: 'Jimmy',		species:'fish' }
];

//	functions you send into other functions are called callback functions
//	because the host function will call back to them
//	filter will loop through each item in the array and for each item it's going to 
//	pass it into the callback function

// var dogs = animals.filter(function(animal) {
// 	return animal.species ==='dog';
// });

var isDog = function(animal) {
	return animal.species ==='dog';
};
var dogs = animals.filter(isDog);

//	for loop
// var dogs = [];
// for (var i = 0; i < animals.length; i++) {
// 	if (animals[i].species === 'dog') 
// 		dogs.push(animals);
// }