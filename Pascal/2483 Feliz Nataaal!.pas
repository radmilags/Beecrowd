program FelizNatal;

var
  n, i: Integer;

begin
  ReadLn(n);
  Write('Feliz nat');
  
  for i := 1 to n do
  begin
    Write('a');
    if i = n then
      WriteLn('l!');
  end;
end.