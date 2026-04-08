# Nodebuster Skill Tree — Implementation Checklist

// X is implemented stat for skill tree usage
// ? (//TODO:)event missing to utilize it within gameplay

## Damage

## Phase 1
### Flat Damage 
- [X] power — +1 damage (15 levels) => (AddFlatBonusDamage)
- [X] proficiency — +3 damage (10 levels) => (AddFlatBonusDamage)
- [X] potency — +6 damage (10 levels) => (AddFlatBonusDamage)
- [X] nodeblade — +25 damage (3 levels) => (AddFlatBonusDamage)
- [X] netblade — +100 damage (5 levels) => (AddFlatBonusDamage)
## Phase 1
### Scaling Damage
- [X?] learning — +1% damage every second (3 levels)
- [X] bloodblade — +0.1% max health as damage (1 level) => (AddHealthPercentageBonusDamage)

## Conditional Damage Nodes
- [ ] connection buster — +5% damage per enemy in area (5 levels)
- [ ] first strike — +25% damage to undamaged enemies (6 levels)
- [ ] ambush — +100% damage to undamaged enemies (4 levels)
- [ ] last strike — +25% damage to enemies below 50% HP (6 levels)
- [ ] finishing blow — +100% damage to enemies below 50% HP (4 levels)

## Phase 3
## Critical Hits
- [ ] crit chance — +10% crit chance (10 levels)
- [ ] crit damage — +50% crit damage (10 levels)
- [ ] big crit — +200% crit damage (8 levels)

## Phase 3
## Boss Damage
- [ ] giant slayer — +50 damage vs bosses (10 levels)
- [ ] colossus slayer — +100% damage vs bosses (10 levels)

## Phase 2
## Attack Speed
- [ ] repeating — +20% attack speed (1 level)
- [ ] repeat-repeating — +20% attack speed (1 level)

## Phase 2
## Attack Size
- [ ] influence — +10% attack size (10 levels)
- [ ] domain expansion — +50% attack size (1 level)
- [ ] b.i.g. — +100 attack size (3 levels)

## Secondary Attacks — Pulse Bolts
- [ ] pulse bolts — shoot projectiles outward (1 level)
- [ ] bolt damage — +25% pulse bolt damage (10 levels)
- [ ] bolt burst — pulse bolts explode on expiry (1 level)
- [ ] bolt count — +1 pulse bolt per attack (5 levels)
- [ ] bolt barrage — +2 pulse bolts per attack (1 level)
- [ ] bolt lethality — +100% pulse bolt damage (3 levels)
- [ ] bit explosion — +1% chance enemies explode into pulse bolts (6 levels)

## Secondary Attacks — Auto-Pulsers
- [ ] auto pulser — drone that attacks nearby enemies (5 levels)
- [ ] pulser pursuit — +20% movement speed (5 levels)
- [ ] pulse thumper — +25% attack size (6 levels)
- [ ] fast pulsing — +20% attack speed (5 levels)
- [ ] it's pulsing time — +50% attack speed (1 level)

## Lightning
- [ ] lightning rod — +5% chance to create lightning (5 levels)
- [ ] thundering — +50% lightning damage (8 levels)
- [ ] chaining — lightning chains +1 time (8 levels)

# Survivability

## Phase 1
## Maximum Health Pool
- [X] endurance — +4 max health (10 levels) => (AddMaxBonusHealth)
- [X] better endurance — +8 max health (8 levels) => (AddMaxBonusHealth)
- [X] big heart — +80 max health (10 levels) => (AddMaxBonusHealth)
- [X] transplant — +300 max health (10 levels) => (AddMaxBonusHealth)
- [X] blood injection — +4000 max health (3 levels) => (AddMaxBonusHealth)
- [X] indomitable — +50000 max health (5 levels) => (AddMaxBonusHealth)
- [X] beyond — +100000 max health (5 levels) => (AddMaxBonusHealth)
- [X?] unending parasite — +1 permanent max HP per kill (1 level) => (AddPerKillMaxBonusHealth)
- [X?] parasite evolution — +3 permanent max HP per kill (1 level)
- [X?] insatiable — +8 permanent max HP per kill (1 level)

## Phase 2
## Health Regeneration
- [ ] repair tool — +0.1 HP/sec (5 levels)
- [ ] self-repair — +4 HP/sec (1 level)
- [ ] scaling regeneration — +1% max HP/sec (10 levels)
- [ ] instant repair — +2% max HP/sec (5 levels)

## Phase 3
## Conditional Health Regeneration
- [ ] salvaging — +1 HP on kill (5 levels)
- [ ] skilled salvager — +8 HP on kill (1 level)
- [ ] sapper — +0.5 HP on hit (5 levels)
- [ ] drainer — +10 HP on hit (3 levels)
- [ ] extraction — restore 1% HP on hit (2 levels)
- [ ] patcher — restore 0.5 HP on pickup (1 level)

## Phase 2
## Armor
- [ ] firewall — +0.2 armor (10 levels)
- [ ] antivirus — +0.6 armor (5 levels)
- [ ] bolster — +2 armor (10 levels)
- [ ] super armor — +5 armor (10 levels)
- [ ] bit armor — +2 armor (20 levels)
- [ ] byte armor — +5 armor (30 levels)
- [ ] net armor — +200 armor (5 levels)
- [ ] blood armor — +1% max HP as armor (5 levels)
- [ ] blood visage — +5% max HP as armor (1 level)
- [ ] growing — +1% armor every second (5 levels)
- [ ] swarm defense system — +2% armor per enemy in area (10 levels)
- [ ] focus armor — +50% armor when attacking ≤8 enemies (5 levels)
- [ ] boss guard — +1 armor vs bosses (10 levels)
- [ ] anti-purple — +25% armor vs bosses (8 levels)

# Miscellaneous

## Phase 3
## Enemy Spawns
- [ ] crowding — +50% spawn rate (15 levels)
- [ ] swarming — +200% spawn rate (1 level)
- [ ] infesting — +100% spawn rate (5 levels)
- [ ] overloading — +400% spawn rate (5 levels)
- [ ] spawn exploders — +5% chance for exploders (1 level)
- [ ] exploder area — +15% explosion size (5 levels)

## Loot & Enemy Colours
- [ ] bit boost — red enemies drop +1 Bits (1 level)
- [ ] node finder — +1% chance for blue enemies (5 levels)
- [ ] node boost — blue enemies drop +1 Nodes (1 level)
- [ ] processor acquisition — chance for yellow enemies (1 level)
- [ ] endless — increased yellow spawn rate (1 level)
- [ ] plundering — +10% double drop chance (5 levels)
- [ ] magnet — +50% pickup range (5 levels)
- [ ] auto-collect — +10% auto-collect chance (8 levels)

## Tabs
- [ ] milestones — unlock Milestones tab (1 level)
- [ ] crypto mine — unlock Crypto Mine tab (1 level)
- [ ] the lab — unlock Laboratory tab (1 level)

## Story / Progression
- [ ] to infinity — ??? (1 level)
- [ ] going nowhere — ??? (1 level)
- [ ] void — ??? (1 level)
- [ ] no return — ??? (1 level)
- [ ] where — ??? (1 level)
- [ ] in the distance — ??? (1 level)
- [ ] something happens — ??? (1 level)
- [ ] event horizon — ??? (1 level)
- [ ] singularity — ??? (1 level)
