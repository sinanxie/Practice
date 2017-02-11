//	http://adripofjavascript.com/blog/drips/basic-inheritance-with-javascript-constructors.html

function SuperHuman (name, superPower) {
	this.name = name;
	this.superPower = superPower;
}

SuperHuman.prototype.usePower = function () {
	console.log(this.superPower + "!");
};

var banshee = new SuperHuman("Silver Banshee", "sonic wail");

//	Outputs: "sonic wail!"
banshee.usePower();


function SuperHero (name, superPower) {
	//	Reuse SuperHuman initialization
	SuperHuman.call(this, name, superPower);

	this.allegiance = "Good";
}

SuperHero.prototype = new SuperHuman();

SuperHero.prototype.saveTheDay = function () {
	console.log(this.name + " saved the day!");
};

var marvel = new SuperHero("Captain Marvel", "magic");

//	Outputs: "Captain Marvel saved the day!"
marvel.saveTheDay();

//	Outputs: "magic!"
marvel.usePower();