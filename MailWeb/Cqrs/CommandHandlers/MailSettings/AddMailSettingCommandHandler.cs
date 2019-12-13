using System;
using System.Threading;
using System.Threading.Tasks;
using MailManager.Models.Interfaces;
using MailWeb.Cqrs.Commands.MailSettings;
using MailWeb.Models;
using MailWeb.Models.Entities;
using MailWeb.Models.Interfaces;
using MailWeb.Models.MailHosts;
using MediatR;

namespace MailWeb.Cqrs.CommandHandlers.MailSettings
{
    public class AddMailSettingCommandHandler : IRequestHandler<AddMailSettingCommand, MailClientSetting>
    {
        #region Properties

        private readonly MailManagementDbContext _dbContext;
        
        #endregion
        
        #region Constructor

        public AddMailSettingCommandHandler(MailManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion
        
        #region Methods
        
        public virtual async Task<MailClientSetting> Handle(AddMailSettingCommand command, CancellationToken cancellationToken)
        {
            var mailSetting = new MailClientSetting(Guid.NewGuid(), Guid.NewGuid(), command.UniqueName, "");
            mailSetting.DisplayName = command.DisplayName;
            mailSetting.Timeout = command.Timeout;

            var mailHost = command.MailHost;
            if (mailHost is SmtpHost smtpHost)
                mailSetting.MailHost = smtpHost;
            else if (mailHost is MailGunHost mailGunHost)
                mailSetting.MailHost = mailGunHost;

            _dbContext.MailSettings
                .Add(mailSetting);

            await _dbContext.SaveChangesAsync(cancellationToken);
            return mailSetting;
        }
        
        #endregion
    }
}