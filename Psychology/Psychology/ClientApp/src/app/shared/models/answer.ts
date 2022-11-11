import { Question } from "./question";

export class Answer {
    public id: number;
    public questionId: number;
    public description: string;
    public percentageIntrovert: number;
    public percentageExtrovert: number;
    public question: Question;
    public checked : boolean;
}