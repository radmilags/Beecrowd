var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

var raio = parseFloat(lines.shift());

var area = 3.14159 * raio * raio;
area = area.toFixed(4); // Arredonda para 4 casas decimais

console.log('A=' + area);
