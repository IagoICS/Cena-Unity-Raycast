# **Cena Unity Raycast**
## Iago Carvalho e André Vitor Pimentel 📖
<p align="justify">
 O nosso projeto criado em C# no Unity tem como objetivo criar uma cena 3d que utiliza das ferramentas de raycast com detector de colisões, 
 assim como a implementação de recursos de iluminação, o projeto é organizado em scripts diferentes, dividos cada um por uma função:
  
🔹 [RayCastShooter](#raycastshooter) <br><br>
🔹 [RayCastReciever](#raycastreciever)<br><br>
🔹 [Elementos e iluminação](#elementos-e-iluminação) 
  
 Além dos scripts principais para utilização do raycast, há também outros scripts responsáveis pelo funcionamento da cena e interface como 'GameManager.cs' e 'UIManager.cs'
 </p>
 
## RayCastShooter
<p align="justify">
O script RayCastShooter é o que utiliza a funçao de RayCast, responsável por criar os raios de detecção de uma colisão.
Primerante teremos a declarações de variáveis, como a variável raycastDistance para definir a distância máxima de alcance dos raios, e layerMask para 
especificar quais camadas de colisão devem ser consideradas durante a detecção.
Dentro do método Update(), há uma verificação para detectar quando o jogador pressiona o botão de disparo. Feito usando o método Input.GetButtonDown().
Uma vez que o botão de disparo é pressionado, o método ShootRaycast() é chamado. Esse método é responsável por disparar o raio de detecção.<br><br>
No método ShootRaycast(), é criado um raio utilizando a função Ray(), que recebe como parâmetros a posição de origem do raio 
(normalmente a posição do objeto em que o script está anexado) e a direção do raio (normalmente na direção do objeto que contém o script).
Em seguida, é utilizado o método Physics.Raycast() para realizar a detecção de colisão com o raio criado. 
Esse método retorna true se o raio atingir um objeto com as camadas de colisão especificadas, Se a detecção de colisão for bem-sucedida, o código dentro do bloco if é executado. 
 </p> 
 
 ## RaycastReciever
 <p align="justify">
O script é resposável por receber as colisões detectadas pelo RayCastShooter, e realizar ações com base nisso. 
script começa com a declaração de variáveis públicas, como OnRaycastHitEvent, que é um evento que será acionado quando ocorrer uma colisão.
Há um método chamado OnRaycastHit(), que é chamado pelo script "RaycastShooter.cs" quando uma colisão é detectada. 
Esse método recebe um parâmetro do tipo RaycastHit, que contém informações sobre a colisão, como o objeto atingido, a posição do impacto e a normal da superfície atingida.<br><br>
Há um método chamado OnRaycastHit(), que é chamado pelo script "RaycastShooter.cs" quando uma colisão é detectada. 
Esse método recebe um parâmetro do tipo RaycastHit, que contém informações sobre a colisão, como o objeto atingido, a posição do impacto e a normal da superfície atingida, 
 além disso, há um uso do evento OnRaycastHitEvent dentro do método OnRaycastHit(). 
Isso permite que outros scripts ou componentes se inscrevam nesse evento e executem suas próprias ações quando uma colisão é detectada.
</p>
 
## Elementos e iluminação 
<p align="justify">
A nossa cena consiste em um mapa simples em que o jogador tem como objetivo atirar no alvo indicado utilizando o arco, para completar com a estética da cena, foram adnado um cenário de uma pequena vila, um campo verde
 com algumas casa e outros elementos, como árvores, pedras e outras construções 
</p>
