using IDHLDeveloperTest.Models;

namespace IDHLDeveloperTest.Services
{
    public interface IClientService
    {
        Task<CharacterList> GetCharacters(int pageNumber);
        Task<Character> GetCharacter(int id);
    }
}
