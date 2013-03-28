var edge = require('edge');

var helloWorld = edge.func('async (input) => { return (int)input + 7; }');

helloWorld(12, function (error, result) {
    if (error) throw error;
    console.log(result);
});