import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Question } from '../models/question';

@Injectable({
    providedIn: 'root'
})
export default class EventService {
    public readonly question = new BehaviorSubject(new Question());
}