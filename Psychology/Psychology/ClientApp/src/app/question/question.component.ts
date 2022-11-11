import { Component, OnInit } from "@angular/core";
import { Answer } from "../shared/models/answer";
import { Question } from "../shared/models/question";
import EventService from "../shared/services/eventService";
import HttpService from "../shared/services/httpService";

@Component({
  selector: "app-question",
  templateUrl: "./question.component.html",
  styleUrls: ["./question.component.css"],
})
export class QuestionComponent implements OnInit {
  questions: Question[];
  answers: Answer[];
  customerAnswers: Answer[] = [];
  completedCount: number = 0;
  constructor(
    private httpService: HttpService,
    private eventService: EventService
  ) {}

  async ngOnInit() {
    await this.getQuestions();

    if (this.completedCount < this.questions.length) {
      this.eventService.question.next(this.questions[this.completedCount]);
      await this.getAnswers(this.questions[this.completedCount].id);
    }
  }

  async next() {
    this.completedCount++;
    if (this.completedCount < this.questions.length) {
      await this.getAnswers(this.questions[this.completedCount].id);
    }
  }

  async preview() {
    this.completedCount--;
    if (this.completedCount < this.questions.length) {
      await this.getAnswers(this.questions[this.completedCount].id);
    }
  }

  async getQuestions() {
    this.questions = await this.httpService.get<Question[]>(
      this.httpService.questionUrl
    );
  }

  async getAnswers(questionId: number) {
    this.answers = await this.httpService.get<Answer[]>(
      this.httpService.answerUrl + "/" + questionId
    );

    this.answers.forEach((f) => {
      var exist = this.customerAnswers.filter((filter) => filter.id == f.id)[0];
      
      f.checked = exist? exist.checked : false;
    });
  }

  async execute(answer: Answer) {
    answer.checked = true;
    var exist = this.customerAnswers.filter(
      (x) => x.questionId == answer.questionId
    );

    if (exist.length > 0) {
      const index: number = this.customerAnswers.findIndex(
        (f) => f.questionId == answer.questionId
      );

      this.customerAnswers = this.customerAnswers.filter(
        ({ questionId }) => questionId !== answer.questionId
      );
    }

    this.customerAnswers.push(answer);
  }

  async submit() {
    this.completedCount++;
  }
}
