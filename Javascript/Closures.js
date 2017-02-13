//	https://www.youtube.com/watch?v=CQqwU2Ixu-U&list=PL0zVEGEvSaeEd9hlmCXrk5yUyqUag-n84&index=5

//	Closure 闭包
//	functions are not just functions, they are also closures
//	the function body has access to variables that are defined outside the function

var me = 'Bruce Wayne';
function greetMe() {
	console.log('Hello, ' + me + '!');
}
greetMe();


function sendRequest() {
	var requestID = '123';
	$.ajax({
		url: '/myUrl',
		success: function(response) {
			alert('Request ' + requestID + ' returned');
		}
	});
}