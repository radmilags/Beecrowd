program produto;
uses crt;
var s: real; 
a: real;
b: real;
begin
read(a);
read(b);
s := (a * 3.5) + (7.5* b);
s := s/11;
writeln('MEDIA = ', s:1:5);
end.
