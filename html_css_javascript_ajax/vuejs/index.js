var app = new Vue({
  el: '#app',
  data: {
      message: 'Do you wanna build app?'
  }
})

var app2 = new Vue({
    el: "#app-2",
    data: {
        message2: "Ban mo trang nay " + new Date().toLocaleString()
    }
})

var app3 = new Vue({
    el: "#app-3",
    data: {
        seen: true
    }
})

var app4 = new Vue({
    el: '#app-4',
    data: {
        todos: [
            {text: 'Hoc JS'},
            {text: 'Hoc Vue'},
            {text: 'Greate'}
        ]
    }
})

var app5 = new Vue({
    el: '#app-5',
    data: {
        message: 'abc cde ghi'
    },
    methods: {
        reverseMessage: function()
        {
            this.message = this.message.split(' ').reverse().join(' ')
        }
    }
})

var app6 = new Vue({
    el: '#app-6',
    data: {
        message: 'Edit'
    }
})