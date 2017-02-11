//	https://www.youtube.com/watch?v=bCqtb-Z5YGQ&list=PL0zVEGEvSaeEd9hlmCXrk5yUyqUag-n84&index=2


var animals = [
	{ name: 'Fluffykins',	species:'rabbit' },
	{ name: 'Caro',			species:'dog' },
	{ name: 'Hamilton',		species:'dog' },
	{ name: 'Harold',		species:'fish' },
	{ name: 'Ursula',		species:'cat' },
	{ name: 'Jimmy',		species:'fish' }
];

//	high order function
// var names = animals.map(function(animal) {
// 	return animal.name + ' is a ' + animal.species;
// });

//	arrow function

//	var names = animals.map((animal) => { return animal.name; });
//	if function logic fit in one line, you can delete '{return}'
var names = animals.map((animal) => animal.name );


// var names = [];
// for (var i = 0; i < animals.length; i++) {
// 	names.push(animals[i].name);
// }

console.log(names);