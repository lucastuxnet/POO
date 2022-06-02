#   Prova: Programação Orientada a Objetos
#   Questão 01
#   Aluno: Lucas Albino Martins
#   Matricula: 12011ECP022
#
#   Escreva uma classe Data cuja instância (objeto) represente uma data. Esta
#   classe deverá dispor dos seguintes métodos:
#   construtor define a data de determinado objeto (através de parâmetros). A data
#   deve ser configurada no formato dd/mm/aaaa.
#   compara recebe como parâmetro um outro objeto da Classe data, compare com a
#   data corrente e retorne:
#   0 se as datas forem iguais;
#   1 se a data corrente for maior que a do parâmetro;
#   -1 se a data do parâmetro for maior que a corrente.
#   getDia retorna o dia da data
#   getMes retorna o mês da data
#   getMesExtenso retorna o mês da data corrente por extenso
#   getAno retorna o ano da data
#   isBissexto retorna verdadeiro se o ano da data corrente for bissexto e falso caso
#   contrário
#   clone o objeto clona a si próprio, para isto, ele cria um novo objeto da classe
#    Data com os mesmos valores de atributos e retorna sua referência pelo
#    método

import datetime

# Comparando duas datas
pMes = datetime.datetime(2021, 5, 11)
sMes = datetime.datetime(2021, 6, 10)

if pMes > sMes:
    print("1 - A data corrente e maior que a do parametro")
elif pMes < sMes:
    print("-1 - A data corrente e menor que a do parametro")
else:
    print("As datas são iguais")

# Imprindo data como string

meses = ["janeiro",
         "fevereiro",
         "março",
         "abril",
         "maio",
         "junho",
         "julho",
         "agosto",
         "setembro",
         "outubro",
         "novembro",
         "dezembro"]

data1 = input("informe a data (dd/mm/aaaa): ")
data2 = input("Digite apenas o ano: ")

print (data1.split("/")[0],
       "de",
       meses[(int(data1.split("/")[1])-1)],
       "de",
       data1.split("/")[2])

#Comparando ano bissesto

def bisAno():
    ano = data2
    # checando se o ano e bissesto
    if(ano.isdigit() == True):
        if( int(ano) % 4 == 0 and int(ano) %100 != 0 or int(ano) % 400 == 0 ):
       # if ( ):
            print ("Este é bissesto!")

        else:
            print ("Este é bissesto!")
    else :
        print("Data não valida, entre com um valor valido!")

bisAno()

