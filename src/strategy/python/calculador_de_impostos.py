# -*- coding: utf-8 -*-

class Calculador_de_impostos(object):
	"""Classe responsavel por realizar o calculo do imposto"""

	def realiza_calculo(self, orcamento, imposto):

		imposto_calculado = imposto.calcula(orcamento)
		print imposto_calculado



"""
	Bloco de testes
"""
if __name__ == "__main__":

	from impostos import ISS, ICMS
	from orcamento import Orcamento

	orcamento = Orcamento(500.0)
	print orcamento.valor

	calculador = Calculador_de_impostos()
	calculador.realiza_calculo(orcamento, ISS())
	calculador.realiza_calculo(orcamento, ICMS())