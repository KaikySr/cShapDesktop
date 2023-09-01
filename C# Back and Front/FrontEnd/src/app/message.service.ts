import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Message } from './Message';

@Injectable({
    providedIn: 'root'
})
export class MessageService {
    constructor(private http: HttpClient) { }
    getAll() 
    {
        return this.http.get<Message[]>("http://localhost:5288/message");
    }
    add(message: Message) 
    {
        return this.http.post("http://localhost:5288/message", message);
    }
}