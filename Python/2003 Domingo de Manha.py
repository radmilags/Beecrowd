import sys

def calcular_atraso_maximo(horario):
    
    horas, minutos = map(int, horario.split(':'))
    minutos_acordado = horas * 60 + minutos

    horario_encontro = 8 * 60 

    atraso_maximo = max(0, (minutos_acordado + 60) - horario_encontro)
    return atraso_maximo

for linha in sys.stdin:
    horario = linha.strip()
    atraso = calcular_atraso_maximo(horario)
    print(f"Atraso maximo: {atraso}")
