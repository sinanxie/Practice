//	https://www.youtube.com/watch?v=Wl98eZpkp-c&index=3&list=PL0zVEGEvSaeEd9hlmCXrk5yUyqUag-n84
//	https://www.youtube.com/watch?v=1DMolJ2FrNY&index=4&list=PL0zVEGEvSaeEd9hlmCXrk5yUyqUag-n84

//** Reduce Basic **
var orders = [
	{ amount: 250 },
	{ amount: 400 },
	{ amount: 100 },
	{ amount: 325 }
];

/*
var totalAmount = orders.reduce(function(sum, order) {
	console.log("hello", sum, order);
	return sum + order.amount;
}, 0);
*/


var totalAmount = orders.reduce((sum, order) => sum + order.amount, 0);


/*
var totalAmount = 0;
for (var i = 0; i < orders.length; i++) {
	totalAmount += orders[i].amount;
}
*/

console.log(totalAmount);


//** Reduce Advanced **
var fs = require('fs');
// import fs from 'fs';

var output = fs.readFileSync('data.txt', 'utf8')
	.trim()		//	remove spaces and line breaks
	.split('\n')
	.map(line => line.split('\t'))
	.reduce((customers, line) => {
		// console.log('hello', line);
		customers[line[0]] = customers[line[0]] || [];
		customers[line[0]].push({
			name: line[1],
			price: line[2],
			quantity: line[3]
		});
		return customers;
	}, {});		//	instead of using number, we use a object literal

console.log('output', JSON.stringify(output, null, 2));
//	2: two spaces for indentation








