function Person(saying) {
	this.saying = saying;
	return {
		dumbObject: true
	}
}

Person.prototype.talk = function() {
	console.log('I say:', this.saying);
};

//	implement 'new' keyword
function spawn(constructor) {
	var obj = {};
	//	2.set the prototype
	Object.setPrototypeOf(obj, constructor.prototype);
	console.log(arguments);
	//	var argsArray = Array.from(arguments);
	var argsArray = Array.prototype.slice.apply(arguments);
	console.log(argsArray.slice(1));
	//	3.execute constructor with "this"
	constructor.apply(obj, argsArray.slice(1));
	//	4.return the created object
	//	return obj;
	return constructor.apply(obj, argsArray.slice(1)) || obj;
}

// var crockford = new Person('SEMICOLANS!!!!lone1');
var crockford = spawn(Person, 'SEMICOLANS!!!!lone1');
console.log('hello', crockford);
crockford.talk();