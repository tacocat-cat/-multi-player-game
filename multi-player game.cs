import random

class Player:
    def __init__(self, name):
        self.name = name
        self.score = 0

class Game:
    def __init__(self):
        self.players = []

    def add_player(self, player):
        self.players.append(player)

    def start_game(self):
        for player in self.players:
            player.score = 0

    def end_game(self):
        winning_player = None
        for player in self.players:
            if player.score > winning_player.score:
                winning_player = player

        print("The winner is:", winning_player.name)

    def play_round(self):
        for player in self.players:
            player.score += random.randint(1, 10)

if __name__ == "__main__":
    game = Game()

    game.add_player(Player("Alice"))
    game.add_player(Player("Bob"))

    game.start_game()

    for i in range(10):
        game.play_round()

    game.end_game()
