// Problema ainda nao resolvido

program hello;
uses crt;
var
n, a, b, c:integer;
begin
    clrscr;
    readln(n);
    a := n div 3600;
    b := (n mod 3600) div 60;
    c := n mod 60;
    writeln(a, ':', b, ':', c);
end.