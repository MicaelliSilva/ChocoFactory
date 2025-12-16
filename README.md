# 🍫 ChocoFactory Simulator

Este repositório contém a minha resolução para um exercício de lógica de programação focado em simulação, laços de repetição e condicoes compostas.

## 📜 O Desafio Proposto

**Contexto:**
Você está programando o painel de uma máquina industrial antiga em uma fábrica de chocolates. O problema dessa máquina é que ela esquenta muito rápido e pode explodir.

**Requisitos do Programa:**

1.  **Entrada de Dados:**
    * Perguntar: "Quantos minutos a máquina deve trabalhar?"
    * Perguntar: "Qual a quantidade de matéria-prima (chocolate líquido) disponível em gramas?"
    * *Validar para que não sejam aceitos valores negativos ou zero.*

2.  **Regras da Simulação (Laço `for`):**
    * A temperatura da máquina começa em **20°C**.
    * A produção total começa em **0 barras**.

3.  **Comportamento a cada minuto:**
    * **Produção:** A máquina produz **50 barras** de chocolate por minuto.
    * **Consumo:** A máquina gasta **1000g** de matéria-prima por minuto.
    * **Aquecimento:** A temperatura sobe **15°C por minuto**.
    * **Resfriamento Automático:** Se a temperatura passar de **80°C**, um ventilador liga automaticamente e a temperatura cai **5°C** (em vez de subir 15°C naquele minuto).

4.  **Condições de Parada:**
    * **Falta de Chocolate:** Se a matéria-prima acabar, encerrar com aviso.
    * **Superaquecimento Crítico:** Se a temperatura atingir ou passar de **120°C**, a máquina explode e o programa encerra com alerta de PERIGO.
