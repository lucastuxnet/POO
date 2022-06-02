#   Prova: Programação Orientada a Objetos
#   Questão 02
#   Aluno: Lucas Albino Martins
#   Matricula: 12011ECP022
#
#   Necessita-se desenvolver um sistema para Controle de Pagamentos. As informações básicas a
#   serem utilizadas serão:
#   CPF, Valor e Código
#   Todo pagamento deverá ser faturado e ao efetuar o lançamento de cada pagamento deve-se
#   espeitar as seguintes regras:
#   1) Quando se tratar de um Pagamento na área de Saúde, o valor da fatura deverá ter um
#   acréscimo de 12%, além de ser informado o nome do estabelecimento.
#   2) Quando se tratar de um Pagamento na área Alimentação, o valor da fatura deverá ter um
#   acrescimento de 5%, além de se informar a descrição do item adquirido.

class Pagtos():

    def __init__(self, _cpf, _valor, _cod):
        self.cpf = _cpf
        self.valor = _valor
        self.cod = _cod
    
    def faturar(self):
        return self.valor
# Getters
    def getCpf(self):
        return self.cpf

    def getValor(self):
        return self.valor
    
    def getCod(self):
        return self.cod
# Setters
    def setCpf(self, _cpf):
        self.cpf = _cpf

    def setValor(self, _valor):
        self.valor = _valor

    def setCod(self, _cod):
        self.cod = _cod

class Alimentacao(Pagtos):

    def __init__(self, cpf, valor, cod):
        Pagtos.__init__(self, cpf, valor, cod)
        self.descricao = ''
        self.valorFaturaAlimentacao = 0
        self.faturar()

    def faturar(self):
        valorFaturaAlimentacao = self.valor * 1.12
        return self.setvalorFaturaAlimentacao(valorFaturaAlimentacao)

    def getDescricao(self):
        return self.descricao

    def getvalorFaturaAlimentacao(self):
        return self.valorFaturaAlimentacao

    def setDescricao(self, _descricao):
        self.descricao = _descricao

    def setvalorFaturaAlimentacao(self, _valorFaturaAlimentacao):
        self.valorFaturaAlimentacao = _valorFaturaAlimentacao
        
class Saude(Pagtos):

    def __init__(self, cpf, valor, cod):
        Pagtos.__init__(self, cpf, valor, cod)
        self.estabelecimento = ''
        self.valorFaturaSaude = 0
        self.faturar()
    
    def faturar(self):
        valorFaturaSaude = self.valor * 1.05
        return self.setvalorFaturaSaude(valorFaturaSaude)

    def getEstabelecimento(self):
        return self.estabelecimento

    def getvalorFaturaSaude(self):
        return self.valorFaturaSaude

    def setEstabelecimento(self, _estabelecimento):
        self.estabelecimento = _estabelecimento

    def setvalorFaturaSaude(self, _valorFaturaSaude):
        self.valorFaturaSaude = _valorFaturaSaude

class Programa():

    def __init__(self):
        self.apresentacao()
        self.bd = []
        self.cadastro()

    def apresentacao(self):
        print("Prova 1 - Questão 2 - Programação Orientada a Objetos")
        print("Necessita-se desenvolver um sistema para Controle de Pagamentos. As informações básicas a")
        print("serem utilizadas serão:")
        print("CPF, Valor e Código")
        print("Todo pagamento deverá ser faturado e ao efetuar o lançamento de cada pagamento deve-se")
        print("respeitar as seguintes regras:")
        print(" 1) Quando se tratar de um Pagamento na área de Saúde, o valor da fatura deverá ter um")
        print("     acréscimo de 12%, além de ser informado o nome do estabelecimento.")
        print(" 2) Quando se tratar de um Pagamento na área Alimentação, o valor da fatura deverá ter um")
        print("     acrescimento de 5%, além de se informar a descrição do item adquirido.")

    def cadastro(self):
        self.cadastroFaturamentoAlimentacao(11640234521, 800, 1, 'Compras 1')
        self.cadastroFaturamentoAlimentacao(11640234522, 1500, 2, 'Compras 2')
        self.cadastroFaturamentoAlimentacao(11640234523, 2000, 3, 'Compras 3')
        self.cadastroFaturamentoSaude(11640234531, 600, 4, 'Consultório 1')
        self.cadastroFaturamentoSaude(11640234532, 1000, 5, 'Consultório 2')
        self.cadastroFaturamentoSaude(11640234533, 1200, 6, 'Consultório 3')

    def cadastroFaturamentoAlimentacao(self, cpf, valor, cod, desc):
        self.cadastro = []
        self.dados = Alimentacao(cpf, valor, cod)
        self.dados.setDescricao(desc)
        self.cadastro.append(self.dados.getCpf())
        self.cadastro.append(self.dados.getValor())
        self.cadastro.append(self.dados.getCod())
        self.cadastro.append(self.dados.getDescricao())
        self.cadastro.append(self.dados.getvalorFaturaAlimentacao())

        self.bd.append(self.cadastro)

    def cadastroFaturamentoSaude(self, cpf, valor, cod, est):
        self.cadastro = []
        self.dados = Saude(cpf, valor, cod)
        self.dados.setEstabelecimento(est)
        self.cadastro.append(self.dados.getCpf())
        self.cadastro.append(self.dados.getValor())
        self.cadastro.append(self.dados.getCod())
        self.cadastro.append(self.dados.getEstabelecimento())
        self.cadastro.append(self.dados.getvalorFaturaSaude())

        self.bd.append(self.cadastro)

    def relatorio(self):
        for line in self.bd:
            print(line)

Programa().relatorio()