import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { HEROES } from '../mock-heroes';
import { HeroService } from '../hero.service';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  selectedHero: Hero;
  heroes: Hero[];

  constructor(private heroService: HeroService,
              private messageService: MessageService) { }

  ngOnInit(): void {
    this.getHeroes();
  }

  onSelect(hero: Hero):void {
    this.selectedHero = hero;
    this.messageService.add('HeroService: Selected hero id=${hero.id}')
  }

  // The new version waits for the Observable to emit the array of heroes—which could happen now or several minutes from now. 
  // The subscribe() method passes the emitted array to the callback, which sets the component's heroes property.
  // This asynchronous approach will work when the HeroService requests heroes from the server.

  getHeroes(): void {
    this.heroService.getHeroes()
        .subscribe(heroes => this.heroes = heroes);
  }
}
