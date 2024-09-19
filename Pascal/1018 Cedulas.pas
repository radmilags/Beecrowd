program cedulas;
uses crt;
var
    cem, cin, vin, dez, cinc, dois, um, a:integer;
begin
    readln(a);
    writeln(a);
    cem := a div 100;
    a := a mod 100;
    cin := a div 50;
    a := a mod 50;
    vin := a div 20;
    a := a mod 20;
    dez := a div 10;
    a := a mod 10;
    cinc := a div 5;
    a := a mod 5;
    dois := a div 2;
    a := a mod 2;
    um := a div 1;

    writeln(cem, ' nota(s) de R$ 100,00');
    writeln(cin, ' nota(s) de R$ 50,00');
    writeln(vin, ' nota(s) de R$ 20,00');
    writeln(dez, ' nota(s) de R$ 10,00');
    writeln(cinc, ' nota(s) de R$ 5,00');
    writeln(dois, ' nota(s) de R$ 2,00');
    writeln(um, ' nota(s) de R$ 1,00');
end.