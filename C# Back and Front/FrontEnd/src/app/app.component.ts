import { Component, OnInit } from '@angular/core';
import { MessageService } from './message.service'
import { Message } from './Message';
@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    message: string = ""
    data: Message[] = [];
    constructor(private service: MessageService) { }
    ngOnInit(): void {
        this.update();
    }
    update() {
        this.service.getAll()
            .subscribe(x => {
                let list: Message[] = []
                x.forEach(m => {
                    list.push(m)
                })
                this.data = list;
                console.log(this.data)
            })
    }
    add() {
        this.service.add({
            id: "0",
            horario: new Date(),
            texto: this.message
        }).subscribe(x => {
            this.update();
        })
        this.message = "";
    }
}