//	https://www.youtube.com/watch?v=CDFN1VatiJA&list=PL0zVEGEvSaeHBZFy6Q8731rcwk0Gtuxub&index=6
//	Object.rreate() is a static method on the object prototype
//	creates a new object with the prototype set to a certain object


const cat = {
	init: function(sound) {
		this.sound = sound;
		return this;
	},
	makeSound: function() {
		console.log(this.sound);
	}
}

function objectCreate(proto) {
	const obj = {};
	Object.setPrototypeOf(obj, proto);
	return obj;
}

// const mark = Object.create(cat);
//	const mark = objectCreate(cat);
//	mark.sound = 'mewuuUUF';
//	mark.init('mewuuUUF');
const mark = Object.create(cat).init('mewuuUUF');
mark.makeSound();

//	const waffles = Object.create(cat);
const waffles = objectCreate(cat);
waffles.sound = 'mrrrrrrooooooooow';
waffles.makeSound();

console.log('Is mark is cat?',
	cat.isPrototypeOf(mark));
