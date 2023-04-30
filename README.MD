# Code example project

This is my project which can provide understanding of my code writing approach.
### Notice

There are some modules which are not presented in this repository, so you can't launch the game or take a look at the multiplayer core part. The main goal of the repository is introduce myself as a game developer and show my approach. If you want to try playing the game, you can use [this link](http://18.189.28.22) to play the demo. You can play together with your friends.
## Project Structure

- **/Scripts**: This folder contains the source code for the project.
  - **/Scripts/Controllers**: Controllers which are represented as states.
  - **/Scripts/Model**: This folder mostly contains classes related to ECS.
  - **/Scripts/View**: There are views and interpolation logic in the folder.

## Features

- Prediction and reconciliation. Player input applies before sending to the server. Every received snapshot is compared with prediction and the input is reapplied in case of misprediction.
- Lag compensation. Every launched projectile is marked by a tick, which the player saw when a projectile was created. Also there is a system which makes a history record of snapshots. It helps to calculate collisions in the past.
- Interpolation. There are two different approaches to interpolating in the repository.
  - Without history and only by the last received snapshot.
  - Interpolation by history. It is a more flexible approach which allows you to hide network's fluctuations.

## Out of scope

As was mentioned above there are some modules which are not included into the repository. 

- Transport layer. I am using a custom lightweight UDP library and WebSocket plugin for WebGL.
- Network service layer. Responsibilities of this layer is to process new connections, messages and authorizing.
- Multiplayer game facade. Responsibilities of this layer is ticking the logic and snapshot syncing. I am using the ["Overwatch"](https://www.youtube.com/watch?v=zrIY0eIyqmI) approach to synchronize snapshots.
- ECS. I am using table based ECS with code generation. There are some features such as data compression, serialization, interpolation, snapshot merge, etc.


