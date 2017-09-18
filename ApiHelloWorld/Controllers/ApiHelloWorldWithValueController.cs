using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ApiHelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class ApiHelloWorldWithValueController : Controller
    {
        [HttpGet]
        public IEnumerable<Value> Get()
        {
            return new Value[] {
              new Value { Id = 1, Text = "안녕하세요" },
              new Value { Id = 2, Text = "반갑습니다" },
              new Value { Id = 3, Text = "또 만나요" }
          };
        }

        [HttpGet("{id:int}")]
        public Value Get(int id)
        {
            return new Value { Id = id, Text = $"넘어온 값: {id}" };
        }

        [HttpPost]
        [Produces("application/json", Type = typeof(Value))]
        [Consumes("application/json")]
        public IActionResult Post([FromBody]Value value)
        {
            // 모델 유효성 검사
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 에러 출력
            }
            return CreatedAtAction("Get", new { id = value.Id }, value); // 201
        }
  
    }
  
    // 모델 유효성 검사
    public class Value
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Text 속성은 필수입력값입니다.")]
        public string Text { get; set; }
    }
}