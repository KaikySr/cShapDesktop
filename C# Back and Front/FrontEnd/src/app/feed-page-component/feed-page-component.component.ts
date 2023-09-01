import { Component, OnInit } from '@angular/core';
@Component({
selector: 'app-feed-page',
templateUrl: './feed-page-component.component.html',
styleUrls: ['./feed-page-component.component.css']
})
export class FeedPageComponentComponent implements OnInit {
user: string | null = null
ngOnInit(): void
{
this.user = sessionStorage.getItem("user")
}
}