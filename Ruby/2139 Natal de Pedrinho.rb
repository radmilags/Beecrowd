require 'date'

natal = Date.new(2016, 12, 25)

while line = gets
  mes, dia = line.split.map(&:to_i)
  data = Date.new(2016, mes, dia)
  dias_faltando = (natal - data).to_i

  if dias_faltando == 0
    puts "E natal!"
  elsif dias_faltando == 1
    puts "E vespera de natal!"
  elsif dias_faltando < 0
    puts "Ja passou!"
  else
    puts "Faltam #{dias_faltando} dias para o natal!"
  end
end
