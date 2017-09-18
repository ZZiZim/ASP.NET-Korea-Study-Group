using System.Collections.Generic;

namespace DotNetNote20.Models
{
    public interface ITechRepository
    {
        void AddTech(Tech model); // 입력
        List<Tech> GetTechs(); // 출력
    }
}