// function counter() {
// 	for (var i = 0; i < 10; i++) {
// 		console.log(i);
// 	};
// 	console.log('after loop', i);
// }
// counter();
// console.log('after loop', i);


//	Immideately invoked function expression
//	IIFE
//	
//	if 'var i' in for loop becomes 'i', 
//	then in compiler, 'var i' will be declared here
//	that's why add "use strict" at the beginning
"use strict";
var i = 99999999;
(function() {
	//	'var i' equals to be declared here, 
	//	because of the hoisting declaration
	for (var i = 0; i < 10; i++) {
		console.log(i);
	};
	// console.log('after loop', i);
})();
console.log('after loop', i);


console.log('let:');
var i = 99999999;
//	let i only accessbile inside of for loop
//	let is block scope not function scope like var is
for (let i = 0; i < 10; i++) {
	console.log(i);
}
if (true) {
	let i = 88888;
}
console.log('after everything', i);


console.log('const');
//	just like let, but you cannot reassign it
//	Not completely immutable, but not reassignable
const x = {
	y: 5
}
x.y = 6;	//	allowed

//	Not allowed, 
// x = {
// 	z:9
// }
console.log(x);


//	Conclusion:
//	We need to minimize mutable state
//	





