using System.Collections.Generic;

namespace Common.EventOpenDataHub
{
    public class EventShortResponseDto
    {
        public int TotalResults { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public string PreviousPage { get; set; }
        public string NextPage { get; set; }
        public string Seed { get; set; }
        public List<EventShortItemDto> Items { get; set; }
    }

    public class EventShortItemDto
    {
        public string Id { get; set; }
        public string Self { get; set; }
        public object Tags { get; set; }
        public EventShortMetaDto Meta { get; set; }
        public bool Active { get; set; }
        public Dictionary<string, EventShortDetailDto> Detail { get; set; }
        public string Source { get; set; }
        public object TagIds { get; set; }
        public string EndDate { get; set; }
        public int EventId { get; set; }
        public object GpsInfo { get; set; }
        public object Mapping { get; set; }
        public bool SoldOut { get; set; }
        public string Display1 { get; set; }
        public string Display2 { get; set; }
        public string Display3 { get; set; }
        public string Display4 { get; set; }
        public string Display5 { get; set; }
        public string Display6 { get; set; }
        public string Display7 { get; set; }
        public string Display8 { get; set; }
        public string Display9 { get; set; }
        public string VideoUrl { get; set; }
        public bool ActiveWeb { get; set; }
        public string ChangedOn { get; set; }
        public string CompanyId { get; set; }
        public object Documents { get; set; }
        public object EventText { get; set; }
        public object GpsPoints { get; set; }
        public string Shortname { get; set; }
        public string StartDate { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyUrl { get; set; }
        public string ContactFax { get; set; }
        public long? EndDateUTC { get; set; }
        public Dictionary<string, string> EventTitle { get; set; }
        public string LastChange { get; set; }
        public List<EventShortRoomBookedDto> RoomBooked { get; set; }
        public object VideoItems { get; set; }
        public string WebAddress { get; set; }
        public bool ActiveToday { get; set; }
        public string AnchorVenue { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyName { get; set; }
        public string ContactCell { get; set; }
        public string ContactCity { get; set; }
        public string ContactCode { get; set; }
        public string EventTextDE { get; set; }
        public string EventTextEN { get; set; }
        public string EventTextIT { get; set; }
        public string FirstImport { get; set; }
        public List<string> HasLanguage { get; set; }
        public EventShortLicenseInfoDto LicenseInfo { get; set; }
        public List<string> PublishedOn { get; set; }
        public string CompanyPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public List<object> ImageGallery { get; set; }
        public long? StartDateUTC { get; set; }
        public object CustomTagging { get; set; }
        public object EventDocument { get; set; }
        public string EventLocation { get; set; }
        public string CompanyCountry { get; set; }
        public string ContactCountry { get; set; }
        public object RelatedContent { get; set; }
        public string ContactLastName { get; set; }
        public string TypicalAgeRange { get; set; }
        public string AnchorVenueShort { get; set; }
        public string ContactFirstName { get; set; }
        public string EventDescription { get; set; }
        public object TechnologyFields { get; set; }
        public string CompanyPostalCode { get; set; }
        public string ContactPostalCode { get; set; }
        public bool ExternalOrganizer { get; set; }
        public bool ActiveCommunityApp { get; set; }
        public string EventDescriptionDE { get; set; }
        public string EventDescriptionEN { get; set; }
        public string EventDescriptionIT { get; set; }
        public string CompanyAddressLine1 { get; set; }
        public string CompanyAddressLine2 { get; set; }
        public string CompanyAddressLine3 { get; set; }
        public string ContactAddressLine1 { get; set; }
        public string ContactAddressLine2 { get; set; }
        public string ContactAddressLine3 { get; set; }
        public object AdditionalProperties { get; set; }
        public string AnchorVenueRoomMapping { get; set; }
    }

    public class EventShortMetaDto
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public bool Reduced { get; set; }
        public string LastUpdate { get; set; }
        public object UpdateInfo { get; set; }
    }

    public class EventShortDetailDto
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string BaseText { get; set; }
        public string Keywords { get; set; }
        public string Language { get; set; }
        public string MetaDesc { get; set; }
        public string AuthorTip { get; set; }
        public string IntroText { get; set; }
        public string MetaTitle { get; set; }
        public string SubHeader { get; set; }
        public string SafetyInfo { get; set; }
        public string ParkingInfo { get; set; }
        public string GetThereText { get; set; }
        public string EquipmentInfo { get; set; }
        public string AdditionalText { get; set; }
        public string PublicTransportationInfo { get; set; }
    }

    public class EventShortRoomBookedDto
    {
        public string Space { get; set; }
        public string Comment { get; set; }
        public string EndDate { get; set; }
        public string Subtitle { get; set; }
        public string SpaceDesc { get; set; }
        public string SpaceType { get; set; }
        public string StartDate { get; set; }
        public long? EndDateUTC { get; set; }
        public string SpaceAbbrev { get; set; }
        public long? StartDateUTC { get; set; }
        public string SpaceDescRoomMapping { get; set; }
    }

    public class EventShortLicenseInfoDto
    {
        public string Author { get; set; }
        public string License { get; set; }
        public bool ClosedData { get; set; }
        public string LicenseHolder { get; set; }
    }
}
