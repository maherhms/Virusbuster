
notes:
observation: health and health regen are trackable values, but mechanics like "heal on kill" also provide a trackable value, no ? for example, the value of "how much to heal when attacking enemies" is variable too that we should track. so what makes a code value actually "core" in this case.
proposal: there shouldn't be any core values. there instead should be a list of variables to track. 
proposal: if a value is ever used more than once (as to become a variable), it should be named and tracked here. Else it can remain as a mechanic.
observation: core values/variables still need to be collected and added to the main initial shared class.
proposal: collect only the variables that are impact a minimalist version of the game. They will depend on other secondary variables.


# Core


## list of mechanics:

### game mechanics

every talent has levels.




### tree related mechanics

Extra damage to undamaged nodes.
affects: attack damage specific to node
```
if enemy_node.node_health == 100% >> enemy_node.incoming_dmg += ... / *= ... #TODO
```

Extra damage to nodes below 50%.
affects: attack damage specific to node
```
if enemy_node.node_health < 50% >> enemy_node.incoming_dmg += ... / *= ...#TODO
```

Extra damage to nodes attacked at the same time ( % increase per enemy)
affects: attack damage specific to node
affects: multiple nodes

Extra damage to bosses
affects: attack damage specific to boss

regen health
#TODO 

heal on kill
#TODO 

heal on attack (per enemy) #TODO 
flat, %

heal when picking up resources #TODO 

gain armor equal to max health #TODO 

gain more armor (%) every second during session #TODO 

gain armor when attacking num of enemies in area #TODO 

gain armor when attacking X number of enemies or less #TODO 

gain armor when attacking bosses #TODO


chance to double resource drop #TODO 

chance to auto collect drops #TODO

## list of resources:

- red bits
- blue bits
- special point (lvl-up)
- boss point
- experience

## list of main values

- attack damage
- attack damage specific to node
- attack damage specific to boss
- crit chance
- crit damage (% of attack dmg)
- attack speed
- attack area size
- pickup range
- health
- health regen
- armor
- spawn rate for red nodes
- spawn rate for bombs
- spawn rate for blue
- red bit drop rate
- blue bit drop rate

### Tabs

milestones


# Extra:

## list of mechanics:


## list of resources:

- netcoin
- processors


## list of values

- spawn rate for processors





---

# Questions for later:

should we be trying to do any sort of limitation/disadvantage when working on this ? (apart from not using AI as much as possible)
because developing a real thing wouldnt have such an openly available complete map of every mechanic and value ever. And having all the value/info about the game could feel like cheating.
But, if the point of this is to just get a feel of how to work together, than this might not matter.


---

# core variables:

attack damage:
- damage value
- dmg specific to notes
- dmg specific to boss

crit
- crit chance
- crit damage (% of attack dmg)

attack speed

attack area size

pickup range

health
- health regen

armor

spawn rates:
- spawn rate for red nodes
- spawn rate for bombs
- spawn rate for blue

drop rates:
- red bit drop rate
- blue bit drop rate


---

# work split

## combat screen focus

#### basic mechanics

screen setup (monogame compatible)

player
- mouse mouvements = zone mouvements
- zone visuals
- interval attack
- attack to enemies (from attack dmg)
- can attack multiple enemies

UI:
- health bar
- red bit collected in session ?
- experience bar

experience:
- when enemies die, player automatically gain experience
- when bar fills up, flag new `special point` gain
- #TODO does bar reset ?

drops/loot
- enemies drop bit when killed (visual)
- when bit in range of mouse, pick up bit (includes animation)
- picked up bit contributes to `red bit resource` 

enemies
- enemy geometry
- enemy color
- enemy spawn position
- enemy mouvement

boss
- boss movement
- boss spawn

general combat sequence
- begin
- boss timer
- end condition: defeat boss
- end condition: health 0

combat progression
- enemy health scale
- enemy damage to player health scale (per enemy)
- passive health loss scale

shared variables getters ( #TODO and setters ?)

#### (basic ver.) Requires shared access to

player damage

player attack interval

player size

player health

player pickup range


## Talent focus
metagame, progression, talent screen, other screens

#### basic ver.

phase 1:
	screen setup (monogame compatible) (1 day)
	
	UI (1 day)
	- breach button
	- resources
	- experience bar
	- #TODO more ?
	
	screen basics (1 day)
	- camera setup
	- grab drag to move camera
	- scroll zoom and unzoom
	- #TODO verify?


phase 2:
	simple talent card (1 day)
	- creation
	- animations
	- stages ( e.g., 2/5)
	- on_click -> dummy effect
	
	talent tree (1 day)
	- visible/invisible conditions ( #TODO verify?)
	- animation when unlock new talent card
	- connection lines

phase 3:
	talent structure/system (4 day)
	- basic talent card class
	- classes/interfaces/structures to setup and call talent classes (connects to talent tree, includes different parameters)
	- distinct on_click value changes and class 
	- backend value system ?


#### intermediate ver.

game values ranges and shapes study (done with and alongside readily done basic combat screen)

advanced UI
- list of expandable tabs (e.g., )

milestone tab
- ...

screen transitions #TODO ?

persistence #TODO ?



---




---

# shared class pseudocode

```


# player vars
var damage;
var health;
var attack_interval;
var pickup_range;
var armor;
var health_regen;

# constant base values
const base_damage;
const base_health;
const base_attack_interval;
const base_pickup_range;
const base_armor;
const base_health_regen;

init(){

# base damage
base_damage = 5

# base interval

# base size

# base health
base_health = 100

# base health regen
heath_regen = 0;

# base pickup range

# base armor
base_armor = 0;

damage = base_damage
health = base_health

}


```
