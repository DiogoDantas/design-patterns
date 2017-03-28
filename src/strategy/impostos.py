# -*- coding: utf-8 -*-

"""
	Modulo responsável por armazenar as regras de calculo dos impostos da aplicação

	Impostos já implementados na aplicação:
		*ISS
		*ICMS

"""

class ISS(object):
	"""Classe que realiza o calculo do ISS"""
	def calcula(self, orcamento):
		return orcamento.valor * 0.1

class ICMS(object):
	"""Clase que realiza o calculo do ICMS"""
	def calcula(self,orcamento):
		return orcamento.valor * 0.06
		
