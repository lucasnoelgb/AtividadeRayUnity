

# Descrição
- Esse projeto foi baseado em jogo de circo ou te parque de diverção o "tomba lata" onde foi feita diversas adaptações onde foi alterado para um cenario que reflete a uma barbearia onde nela foi criado uma cena com os elementos RayCast Destroy e os Prefabs.


# Projeto
https://drive.google.com/file/d/1803PK_2DUSLVb_dLWALZcDEwTCB6C3nb/view?usp=drive_link

# Explicação do Scripts

## RayCast 
- Primeiramente foi criado a classe "raycastDistance" para denominar que o raio irá até a distancia de 20.
- Em seguida usando o 'Ray' ele vai gerar um raio a partir do objeto que esta o script, e juntamente com o hitinfo que armazenará a informação da colisão.
- Esses 3 parâmetros serão executados no 'Physics.Raycast()' que ficara atualizando a cada frame por causa do 'Update()'.
  
## Destroy
- Se o raio acertar o shampoo do Cristiano Ronaldo , o Destroy() será chamado para destruir a instância do objeto que acaba de ser colidido.
- O método Debug.Log() é usado para mostrar uma mensagem no console com a mensagem "Você Destruiu o Cr7!" está mensagem foi feita inicialmente para testar se o script desenvolvido foi executado de maneira correta mais mantido pela sua ajuda.

![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/9d60c865-71de-4060-bc5d-2f10916a6123)



# Movimentação do Mouse 
- 'Sensibilidade': Define a sensibilidade do mouse durante a cena no eixo X e Y (atualmente definida como 5.0f).
- 'mouseX e mouseY': Armazenam a posição atual do mouse no eixo X e Y, . em seguida, ajusta a rotação do objeto no cenário 'através do transform.eulerAngles' com base nessas variáveis, fazendo que esse script possa fazer a câmera ser movimentada de forma horizontal e vertical.
  
![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/1dcbf265-17d1-4d27-a0f4-c1ffcaa7ab71)


## Ingnore RayCast
- O ignore RayCast é uma layer que é adicionado em todos os objetos que não serão destruídos na cena para que eles possam ignorar o raio do 'RayCast' fazendo que os objetos da cena não sejam destruídos e afetados pelos RayCast.
  
![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/436f263f-d1cb-49a0-af3e-909ebb117e2b)


# Prefabs 
- Sacador de cabelo onde foi adionado para acompanhar a câmera ja que esta acoplado a ela.
  
![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/bd3caddb-5319-49a1-8669-35ca6fa3560b)<br>


- O Sofá foi adicionado apenas para ambientar o local adicionar alguns elemento a mais para ficar similar a
uma barbearia.

![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/fde9220e-32c8-4741-9186-bb73ec975264)

# Objeto que será destruido
![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/9a477cad-1afc-4e5d-a910-623e3172e0e6)
![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/3e585ab4-f7b3-4ee3-a6d3-099182cc84f3)












