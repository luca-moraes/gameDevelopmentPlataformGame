# Plataform Game: Plataformas de Duna
A atividade tinha como objetivo o desenvolvimento de um jogo de plataforma. Além das plataformas, conceitos como movimentação de câmeras deveriam ser utilizados para a imersão do jogador.

No caso do presente projeto, o jogo foi desenvolvido tendo em mente a temática da série de livros Duna, que tem como autor o escritor Frank Herbert. A temática foi usada apenas para propósitos de aprendizado e diversão pessoal. Todos os direitos originais da obra pertencem ao autor e às organizações responsáveis que possuem direitos autorais da série Duna.

Espero que esse pequeno trabalho possa ser considerado uma singela homenagem a Frank Herbert e sua tão grandiosa obra.

~ _Father, the sleeper has awakened!_ ~


# Objetivos das fases:
Todas as fases possuem 3 objetivos para serem concluídas, sendo eles:

1. Derrotar os inimigos Sardaukars.

2. Coletar a especiaria Mélange.

3. Obter a água da vida após o escudo que a protege ser removido ao cumprir os dois itens anteriores.

| **Inimigo Sardaukar** | **Especiaria Mélange** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/enemy.png" alt="Inimigo Sardaukar" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/spice.png" alt="Especiaria Mélange" width="450" height="250"> |

| **Escudo Bolha** | **Água da Vida** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/sield.png" alt="Escudo Bolha" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/water.png" alt="Água da Vida" width="450" height="250"> |

<!--
<div style="display: grid; grid-template-columns: repeat(2, 1fr); gap: 10px; width: 80%; margin: 0 auto;">
    <figure style="text-align: center; display: flex; flex-direction: column;">
        <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/enemy.png" alt="Description of the image" width="300" height="200" style="height: auto; display: block; margin: 0 auto;">
        <figcaption>Inimigo Sardaukar</figcaption>
    </figure>
    <figure style="text-align: center; display: flex; flex-direction: column;">
        <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/spice.png" alt="Description of the image" width="300" height="200" style="height: auto; display: block; margin: 0 auto;">
        <figcaption>Especiaria Mélange</figcaption>
    </figure>
    <figure style="text-align: center; display: flex; flex-direction: column;">
        <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/sield.png" alt="Description of the image" width="300" height="200" style="height: auto; display: block; margin: 0 auto;">
        <figcaption>Escudo Bolha</figcaption>
    </figure>
    <figure style="text-align: center; display: flex; flex-direction: column;">
        <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/water.png" alt="Description of the image" width="300" height="200" style="height: auto; display: block; margin: 0 auto;">
        <figcaption>Água da Vida</figcaption>
    </figure>
</div>
-->


# Fases do jogo:
O jogo possui dez fases, a estrutura geral é basicamente a mesma, porém, as plataformas e itens estão poscionados em locais diferentes e a quantidade e posição dos inimigos também mudam. Uma visão geral das fases pode ser vista nas imagens abaixo:

| **Fase 1** | **Fase 2** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f1.png" alt="Escudo Bolha" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f2.png" alt="Água da Vida" width="450" height="250"> |

| **Fase 3** | **Fase 4** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f3.png" alt="Escudo Bolha" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f4.png" alt="Água da Vida" width="450" height="250"> |

| **Fase 5** | **Fase 6** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f5.png" alt="Escudo Bolha" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f6.png" alt="Água da Vida" width="450" height="250"> |

| **Fase 7** | **Fase 8** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f7.png" alt="Escudo Bolha" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f8.png" alt="Água da Vida" width="450" height="250"> |

| **Fase 9** | **Fase 10** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f9.png" alt="Escudo Bolha" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/f10.png" alt="Água da Vida" width="450" height="250"> |

| **Menu do jogo** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/menu.png" alt="Escudo Bolha" width="925" height="700"> |

# Sprites do jogo:
O jogo utilizou sprites _open source_ prontos, fornecidos gratuitamente no site [craftpix.net](https://craftpix.net/). A movimentação do personagem foi desenvolvida em partes utilizando um _controller_ de animação da _Unity_ e, em alguns detalhes, no código do _script_ que controla a movimentação do personagem, como pode ser visto nas imagens abaixo:

| **_Controller_ da animação** | **_Sprites_ livres** |
| --- | --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/animator.png" alt="Escudo Bolha" width="450" height="250"> | <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/sprites.gif" alt="Água da Vida" width="450" height="250"> |

| **_Start_ do _PlayerControl.cs_** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/start.png" alt="Escudo Bolha" width="450" height="250"> |

| **_Script_ das colisões** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/colisao.png" alt="Escudo Bolha" width="600" height="400"> |

| **_Script_ da movimentação** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/controles.png" alt="Escudo Bolha" width="600" > |


# Controle do jogo: 
O jogo possui _scripts_ para movimentação da câmera, que segue o movimento do personagem nas plataformas. Um _GameManager_ faz o controle central do jogo, enquanto um _ScoreManager_ cuida de maneira estática da pontuação geral das fases (a classe _static_ funcionou melhor que o padrão _singleton_ no caso do jogo). Existe uma classe para os atributos do personagem e classes para gerenciar a colisão com os itens, todas visíveis nas imagens abaixo:

| **_Script_ da câmera** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/camera.png" alt="Escudo Bolha" width="600" height="400"> |

| **_Script_ do _GameManager_** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/gm.png" alt="Escudo Bolha" width="600" > |
O _GameManage_ utiliza uma _HashTable_ para fazer o apontamento das fases <br>e _arrays_ para monitorar os inimigos.

| **_Start_ do _GameManager_** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/gmstart.png" alt="Escudo Bolha" width="600" > |

| **Monitoramento dos inimigos** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/sardaukars.png" alt="Escudo Bolha" width="600" > |

| **_Update_ do _GameManager_** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/update.png" alt="Escudo Bolha" width="600"> |

| **Troca de cenas** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/chs.png" alt="Escudo Bolha" width="600" > |

| **Controle dos finais** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/finais.png" alt="Escudo Bolha" width="600" > |

| **Coleta da especiaria** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/caleche.png" alt="Escudo Bolha" width="300" > |

| **Classe estática** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/scoremanager.png" alt="Escudo Bolha" width="600" height="400"> |
A Classe seria um _ScoreManager_ , o seu nome foi alterado em referência<br> aos Fremen de Arrakis, e o atributo do _array_ em alusão ao Duque Leto.

| **Classe dos atributos** |
| --- |
| <img src="https://github.com/luca-moraes/gameDevelopmentPlataformGame/blob/main/imagens/statuspontuacao.png" alt="Escudo Bolha" width="600" height="400"> |
A Classe de atributos teve o nome alterado em referência a Guilda Espacial,<br> e o atributo de vida em alusão a Lady Jéssica.

---

# Ya Hya Chouhada Muad'Dib!

![Kwisatz Haderach](imagens/muaddib.jpg)

---
