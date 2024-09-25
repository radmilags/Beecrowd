program notas;

var
  n: real;
  cem, cinq, vint, dez, cinc, dois, um, c50, v25, dezc, c5, c1: integer;

begin
  readln(n);
  n := n + 0.00001; // Ajuste para evitar problemas de precisão

  cem := trunc(n / 100);
  n := n - cem * 100;

  cinq := trunc(n / 50);
  n := n - cinq * 50;

  vint := trunc(n / 20);
  n := n - vint * 20;

  dez := trunc(n / 10);
  n := n - dez * 10;

  cinc := trunc(n / 5);
  n := n - cinc * 5;

  dois := trunc(n / 2);
  n := n - dois * 2;

  um := trunc(n / 1);
  n := n - um;

  c50 := trunc(n / 0.50);
  n := n - c50 * 0.50;

  v25 := trunc(n / 0.25);
  n := n - v25 * 0.25;

  dezc := trunc(n / 0.10);
  n := n - dezc * 0.10;

  c5 := trunc(n / 0.05);
  n := n - c5 * 0.05;

  c1 := trunc(n / 0.01);

  writeln('NOTAS:');
  writeln(cem, ' nota(s) de R$ 100.00');
  writeln(cinq, ' nota(s) de R$ 50.00');
  writeln(vint, ' nota(s) de R$ 20.00');
  writeln(dez, ' nota(s) de R$ 10.00');
  writeln(cinc, ' nota(s) de R$ 5.00');
  writeln(dois, ' nota(s) de R$ 2.00');
  writeln('MOEDAS:');
  writeln(um, ' moeda(s) de R$ 1.00');
  writeln(c50, ' moeda(s) de R$ 0.50');
  writeln(v25, ' moeda(s) de R$ 0.25');
  writeln(dezc, ' moeda(s) de R$ 0.10');
  writeln(c5, ' moeda(s) de R$ 0.05');
  writeln(c1, ' moeda(s) de R$ 0.01');
end.